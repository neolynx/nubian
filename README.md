# nubian - debianize nuget packages

Prerequisites:

```
apt install devscripts debhelper fakeroot
```

Download and package:
```
./nubian package NEventStore 5.2.0
```
Install:
```
sudo dpkg -i neventstore_0.0.0.0_all.deb
```
Build project:
```
cd src/nubian.Demo/
make
```

## TODO

* Get version from nupkg
* Try nuget local repo: https://wiki.debian.org/Teams/DebianMonoGroup/NuGet
* Handle nuget dependencies
* Try to use FrameworkPath instead of link
* Runtime packages
