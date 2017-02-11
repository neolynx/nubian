
all:
	../../nubian nuget-localonly
	nuget restore -PackagesDirectory packages/
	xbuild
	../../nubian nuget-nolocal


clean:
	xbuild /t:Clean
	rm -rf packages/
	../../nubian nuget-nolocal
