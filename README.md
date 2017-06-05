# EnScript-Samples
This repository is a collection of EnScript code samples for use in the [Guidance Software Inc.](http://www.guidancesoftware.com) EnCase application. It is very much a work in progress.

EnScript is a proprietary scripting language with roots in C++. It also has elements of Java and C#.

EnScripts can include other EnScript library files, resource files and .NET assemblies. They can be packaged into files with an 'EnPack' file-extension.

Each script in this repository has been tested/developed using EnCase 7/8 unless specified otherwise.

If you'd like to see an example of how to accomplish a particular thing please feel free to raise an issue and I will look at it as soon as I'm able.

## FAQ
__Q) Why are many EnScripts in *.EnPack format? Is it to hide the code?__

A) Maybe, but in most cases the code is packaged because it consists of more than one source-code file. Packaging multiple files together overcomes compatibility issues when two scripts use different versions of the same library file.

__Q) Can I have a script's source-code?__

A) It depends on the author - you will have to ask. GSI Training EnScripts are not open-source - they took a lot of time to develop. That said, you can always email the author if you'd like to know a little more about one particular aspect of a script's operation. He/she will probably be happy to send you a code-snippet demonstrating how to accomplish a particular task.

__Q) Can I write EnScripts without EnCase?__

A) Yes, but you won't be able to compile or run them. One option is to apply to become an EnCase App Central Developer. If you're accepted, you will receive an EnCase licence that can be used for EnScript development. For more details click the following link -

* https://www.guidancesoftware.com/app/become-a-developer

__Q) Is there any documentation available for EnScript?__

A) EnCase ships with an EnScript help file that contains numerous examples. There is also an EnScript class browser accessible from the EnScript editor tab in EnCase itself. An EnScript Fundamentals training manual together with a copy of the EnScript language reference guide is available from the following URL -

* http://tiny.cc/0zw4ky

__Q) Is there any training available for EnScript?__

A) Yes - 

* http://tiny.cc/91w4ky
