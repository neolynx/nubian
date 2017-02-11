# nubian - debianize nuget packages

Prerequisites:

```
$ sudo apt install devscripts debhelper fakeroot xmlstarlet
```

Download and package:
```
$ ./nubian package NEventStore 5.2.0
```
Install:
```
$ sudo dpkg -i nupkg-neventstore_5.2.0_all.deb
```
Build project:
```
$ cd src/nubian.Demo/
$ make
```

Package info:
```
$ dpkg -I nupkg-neventstore_5.2.0_all.deb
 new debian package, version 2.0.
 size 1227590 bytes: control archive=597 bytes.
     525 bytes,    10 lines      control
     153 bytes,     2 lines      md5sums
 Package: nupkg-neventstore
 Version: 5.2.0
 Architecture: all
 Maintainer: Some One <some.one@email>
 Installed-Size: 1235
 Section: devel
 Priority: optional
 Homepage: http://neventstore.org
 Description: NEventStore is a persistence agnostic event sourcing library for .NET. The primary use is most often associated with CQRS.
  The purpose of the EventStore is to represent a series of events as a stream. Furthermore, it provides hooks whereby any events committed to the stream can be dispatched to interested parties.

$ dpkg -c nupkg-neventstore_5.2.0_all.deb
drwxr-xr-x root/root         0 2017-02-11 18:22 ./
drwxr-xr-x root/root         0 2017-02-11 18:22 ./usr/
drwxr-xr-x root/root         0 2017-02-11 18:22 ./usr/share/
drwxr-xr-x root/root         0 2017-02-11 18:22 ./usr/share/nupkg/
-rw-r--r-- root/root   1255657 2017-02-11 18:22 ./usr/share/nupkg/NEventStore.5.2.0.nupkg
drwxr-xr-x root/root         0 2017-02-11 18:22 ./usr/share/doc/
drwxr-xr-x root/root         0 2017-02-11 18:22 ./usr/share/doc/nupkg-neventstore/
-rw-r--r-- root/root       154 2017-02-11 18:22 ./usr/share/doc/nupkg-neventstore/changelog.gz
```

## TODO

* Handle nuget dependencies
* Generate run-time packages
* Sanitize debian/control line lenghts
