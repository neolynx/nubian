# nugian - debianize nuget packages

Download and package:

./nubian package NEventStore 5.2.0

Install:

sudo dpkg -i neventstore_0.0.0.0_all.deb

Build project:

cd src/nubian.Demo/
make


## TODO

* Get version from nupkg
* Handle nuget dependencies
* Try to use FrameworkPath instead of link
* Runtime packages
