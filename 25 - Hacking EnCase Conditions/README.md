A condition is a filter written for the user.

Both can be used to filter responsive nodes given a set of criteria.

The key difference between a regular EnScript and an EnScript filter is that the `MainClass::Main()` function in a filter is called repeatedly and returns a Boolean value, which if `true`, will cause the node being filtered to be displayed.

In a regular EnScript, the `MainClass::MainFunction()` is only called once, and the programmer must write the code needed to process data.

In general terms, a regular EnScript is more flexible, but it cannot control what is currently being displayed to the user - only a condition/filter can do that.

Accordingly, there are times when writing a filter is the only option, and building one by customizing an existing condition may save time as well as provide an opportunity to learn by hacking.

The condition in this folder (the `*.EnCondition` file) is designed to find artifacts (records) with one of a number of given Internet message-IDs.

The condition's source-code (as displayed by EnCase) was copied into the **Find Internet Message IDs (Modified).EnFilter** file, which was then modified to add the following functionality:

* Configure the text control so as to accept a string with the maximum possible length (the default is 512-characters)
* Use string-arrays to track the responsive and non-responsive message-IDs, which are written to the console after processing by code in the `MainClass` destructor
