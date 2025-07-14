# EnScript-Samples
This repository is a collection of EnScript code samples for use in the [OpenText Forensic (OTF) and OpenText Endpoint Investigator (OTEI) applications](https://www.opentext.com/solutions/digital-forensic-investigations) (formerly EnCase). It is very much a work in progress.

**Please note that you use the code in this repository at your own risk. No warranty regarding its use is given or implied, and I cannot provide any support for it.**

## Background

EnScript is a proprietary scripting language with roots in C++. It also has elements of Java and C#.

EnScripts can include other EnScript library files, resource files and .NET assemblies. They can be packaged into files with an 'EnPack' file-extension.

Each script in this repository has been tested/developed using the current version of OTF/OTEI unless specified otherwise.

If you'd like to see an example of how to accomplish a particular thing please feel free to raise an issue and I will look at it as soon as I'm able.

A substantial number of production EnScripts are available on the OpenText Marketplace -

* https://marketplace.opentext.com/cybersecurity/category/security-cloud

## FAQ
__Q) Why are many EnScripts in *.EnPack format? Is it to hide the code?__

A) Maybe, but in most cases the code is packaged because it consists of more than one source-code file. Packaging multiple files together overcomes compatibility issues when two scripts use different versions of the same library.

__Q) Can I have a script's source-code?__

A) It depends on the author - you will have to ask. OpenText Training EnScripts are not open-source - they took a lot of time to develop. That said, you can always email the author if you'd like to know a little more about one particular aspect of a script's operation. He/she will probably be happy to send you a code-snippet demonstrating how to accomplish a particular task.

__Q) Can I write EnScripts without OTF/OTEI?__

A) Yes, but you won't be able to compile or run them. One option is to apply to become an App Central Developer. If you're accepted, you will receive an OTF licence that can be used for EnScript development. For more details click the following link -

* [App Central Developer Enquiry](mailto:encasetraining@opentext.com?subject=Becoming%20an20App%20Central%20Developer)

__Q) Is there any documentation available for EnScript?__

A) OTF/OTEI ships with an EnScript help file that contains numerous examples. There is also an EnScript class browser accessible from the EnScript editor tab in OTF/OTEI itself. An EnScript Fundamentals training manual together with a copy of the EnScript language reference guide is available from the following URL -

* http://tiny.cc/0zw4ky

__Q) Is there any training available for EnScript?__

A) Yes - 

* https://www.opentext.com/TrainingRegistry/course/details/2626

__Q) Can I ask for a script example showing how to accomplish a particular task?__

A) Yes - you can ask for an example by [submitting an issue](https://github.com/sdckey/EnScript-Samples/issues) with the **enhancement** label. Please bear in mind that I can't accommodate every request nor can I provide anything but generic code. The idea is to teach *you* how to write EnScript, not to provide an EnScript development service.

__Q) Do you have any advice regarding transitioning EnCase 6 scripts to EnCase/OTF/OTEI >= 7?__

A) Yes, please view [this](https://github.com/sdckey/EnScript-Samples/blob/master/24%20-%20Transitioning%20From%20EnCase%206/EnScript%20Changes%20From%20EnCase%20V6%20to%20EnCase%20V7%20(V3).pdf) document.

__Q) When I search your code using GitHub, why don't I see all of the matching search-hits?__

A) Code-searching in GitHub has some limitations - click [here](https://docs.github.com/en/search-github/searching-on-github/searching-code#considerations-for-code-search) for more details. To overcome this, you can download your own copy of the code and search that.
