#!/usr/bin/make -f
# -*- makefile -*-

all:
	nubian-nuget restore -Source /usr/share/nupkg -PackagesDirectory packages/ -nocache
	xbuild nubian.Demo.csproj /p:Configuration=Release


clean:
	xbuild /t:Clean
	rm -rf packages/
