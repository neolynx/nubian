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
$ sudo dpkg -i neventstore_5.2.0_all.deb
```
Build project:
```
$ cd src/nubian.Demo/
$ make
```

Package info:
```
$ dpkg -I neventstore_5.2.0_all.deb
 new debian package, version 2.0.
 size 2023648 bytes: control archive=708 bytes.
     545 bytes,    10 lines      control
     419 bytes,     5 lines      md5sums
 Package: neventstore
 Version: 5.2.0
 Architecture: all
 Maintainer: Some One <some.one@email>
 Installed-Size: 7445
 Section: devel
 Priority: optional
 Homepage: http://neventstore.org
 Description: NEventStore is a persistence agnostic event sourcing library for .NET. The primary use is most often associated with CQRS.
  The purpose of the EventStore is to represent a series of events as a stream. Furthermore, it provides hooks whereby any events committed to the stream can be dispatched to interested parties.
```

## TODO

* Try nuget local repo: https://wiki.debian.org/Teams/DebianMonoGroup/NuGet
* Handle nuget dependencies
* Try to use FrameworkPath instead of link
* Runtime packages
