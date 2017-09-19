## InfoCollection Azure Could Service

#### Author: Yun Liu (t-yunliu@microsoft.com or liuwuliuyun@qq.com)

Last Modified Date: 2017/9/18

### Introduction
This is an azure cloud service designed to collect users' IP addresses when they login *HoloMessages*[1] application.
Click "LearnMore" button at the homepage, you'll be guided to the UserInfo page where all user login infoes are displayed.
Currently this website is not able to analyse real IP addresses if VPN or other IP hiding technology is used.
For users hiding behind a NAT, the IP address will be the IP address of the NAT.

[1] About *HoloMessages*

*HoloMessages* is an close source intern project of Microsoft. 

Designers: Yun Liu, Dongze Li, Roqi Tang, Gang Pan and Jimmy Zhu (Order does not matter).

*HoloMessages* is an HoloLens &copy application can be find on Windows Store.

You can download the current version at https://www.microsoft.com/en-sg/store/p/holomessages/9n8gpmxm5vcw.

However, current version of HoloMessages on Windows Store does **not** support userinfo collection for privacy concern.
