# UnityDisplayTextOnGaze
How to display a 3D text in Unity only when you want

Suppose you are moving around in a Unity environment, say a VR environment. You want information about certain things to pop up only when you look at them and otherwise they shouldn't be there. Here is a C# script that makes the Text Game Object appear and disappear as and when required. 

A counter is used in the C# script which starts ticking when you're looking at the button, if you're looking at for more than a threshold time, it triggers the button and the text is displayed. It is because it is assumed that if you have been looking at an object for quite some time then you're interested in it and thus would want to know more about it. Therefore, information is displayed and the moment you look away, the 3D text goes away.
