## InfoCollection Azure Could Service

#### Author: Yun Liu (t-yunliu@microsoft.com or liuwuliuyun@qq.com)

Last Modified Date: 2017/9/18

### Introduction
This is an azure cloud service designed to collect users' IP addresses when they login *HoloMessages*[1] application.
Click "LearnMore" button at the homepage, you'll be guided to the UserInfo page where all user login infoes are displayed.
Currently this website is not able to analyse real IP addresses if VPN or other IP hiding technology is used.
For users hiding behind a NAT, the IP address will be the IP address of the NAT.

### Usage
**1. Set up cloud service in Azure**

If you have no experience with Azure, please refer to this article https://docs.microsoft.com/en-us/azure/cloud-services/cloud-services-dotnet-get-started.

**2. Change database connection string [Web.config]**

In this project, I use my own Azure subscription to connect to a cloud database, and you should change the connection string to your own. I have changed my password and username after publishing this project on Github, so you'll not be able to connect to the cloud database if you don't change database connection string.

**3. Change SSL certificate**

In this project, I use a self-signed certificate. You should config your own SSL cert to build a secure channel to communicate with server. If you don't know where to start, try read this document https://docs.microsoft.com/en-us/azure/cloud-services/cloud-services-configure-ssl-certificate.

**4. Publishing to Azure**

My Visual Studio Version: Community 2017 Version 15.3.3


### Copyright
All intern projects' copyright is belonged to Microsoft. You shall not use this project for any commertial activity.

[1] About *HoloMessages*</br>
*HoloMessages* is an close source intern project of Microsoft. </br>
Designers: Yun Liu, Dongze Li, Roqi Tang, Gang Pan and Jimmy Zhu (Order does not matter).</br>
*HoloMessages* is an HoloLens&copy; application can be find on Windows Store.</br>
You can download the current version at https://www.microsoft.com/en-sg/store/p/holomessages/9n8gpmxm5vcw.</br>
However, current version of HoloMessages on Windows Store does **not** support userinfo collection for privacy concern.
