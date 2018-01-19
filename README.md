# { Launch-Pad }
[![npm](https://img.shields.io/npm/l/express.svg)](https://github.com/michaelburns/LaunchPad/blob/master/LICENSE) 
[![Build status](https://ci.appveyor.com/api/projects/status/github/michaelburns/launchpad?branch=master&svg=true)](https://ci.appveyor.com/project/michaelburns/launchpad)
[![Stories in Ready](https://badge.waffle.io/michaelburns/LaunchPad.png?label=ready&title=Ready)](https://waffle.io/michaelburns/LaunchPad)


### PowerShell Command Center
##### Automation for Everyone
--------------


ASP.NET CORE 2.0 MVC

This project is looking for contributors. If you have a feature you'd like to see implemented or a bug you'd liked fixed, the best and fastest way to make that happen is to implement it and submit it back upstream for consideration. All contributions will be given thorough consideration.

The project is not ready for production environments and should be used for testing only. 

#### Get started with v0.0.1-alpha
- [Install Launch-Pad](https://github.com/michaelburns/LaunchPad/releases/download/v0.0.1-alpha/launch-pad.exe)
  - [Release Notes](https://github.com/michaelburns/LaunchPad/releases/tag/v0.0.1-alpha)


#### Get started contributing in 3 easy steps:
- [Install ASP.NET 5 RC1](https://get.asp.net/)  
- Clone the project to [Visual Studio 2015](https://www.visualstudio.com/en-us/products/visual-studio-community-vs.aspx) or [Visual Studio Code](https://www.visualstudio.com/en-us/products/code-vs.aspx)
  - There's even a [GitHub extension](https://visualstudio.github.com/)
- Run the Entity Framework 7 commands from the ./src/LaunchPad directory 
  - ``` dnx ef migrations add InitialDB ```
  - ```dnx ef database update ```
  
##### Default Admin Account:
Username: admin  
Password: Admin1234!


#### Key Features
* Secure central location for all your scripts
* User/Role Management
* Auditing - who ran what when
* Syntax highlighting editor
* Launch scripts from the web
* Schedule scripts with recurring options
* Ability to leverage parameters and variables in your scripts
* View results

--------------
#### Screenshots

##### Scripts Dashboard

![Launch-Pad Dashboard](http://i.imgur.com/YhM1Q2U.png)

##### Launching Scripts with Parameters

![Launch-Pad Launch Script with Params](http://i.imgur.com/9GwPf3m.png)

##### View Output

![Launch-Pad View Output](http://i.imgur.com/xNLBn8E.png)

##### Schedule 

![Launch-Pad Schedule Script with Params](http://i.imgur.com/NcoVMzQ.png)


##### Create and Edit Scripts 

![Launch-Pad Create and Edit Scripts](http://i.imgur.com/fp2KRy4.png)

--------------


#### Planned Features
* Define custom end user roles (Exchange, Business Departments)
* Publish scripts to dashboard for end users to launch/schedule scripts they need
* Export and/or email script results
* Email alerts on failures
* Version Control

--------------


#### Special Thanks To
* [HangFire](http://hangfire.io/) for fire-and-forget tasks
* [Ace.js](https://ace.c9.io/) editor for script editing and syntax highlighting
