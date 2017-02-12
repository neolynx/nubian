#!/usr/bin/make -f
# -*- makefile -*-

all:
	nuget restore -Source /usr/share/nupkg -PackagesDirectory packages/
	xbuild


clean:
	xbuild /t:Clean
	rm -rf packages/
