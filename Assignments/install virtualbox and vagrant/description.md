# Vagrant folder - UBUNTU + .NET CORE
-------------------------------------
### The vagrant file is configured using the box ubuntu/xenial64 for ubuntu 16.04LTS ###
### Then using the following inline shell commands the dotnet core is installed ###

```
echo "========Installing .net core on ubunt"
	 echo "========Registering Microsoft key and feed!"
	 wget -q https://packages.microsoft.com/config/ubuntu/16.04/packages-microsoft-prod.deb
	 sudo dpkg -i packages-microsoft-prod.deb
	 echo "=========Installing .net SDK"	
	 sudo apt-get -y install apt-transport-https
	 sudo apt-get update
	 sudo apt-get -y install dotnet-sdk-2.1
	 echo "=========.NET SDK installation completed!"	   
```

### Finally a dotnet core console application is developed with a welcome text ###
### Using a provisioning script welcome.sh the program is finally compiled and run to show a welcome screen ###

```
cd /vagrant/dotnet/welcomescreen
dotnet run
```


