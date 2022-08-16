# ETA_Calculator
ETA Calculator

Before I catch too much flack for it, yes, I know there is no commenting in the code at all.  That was silly.  Looking at it now, over a decade later, it would have been great if there were some comments.

Since "ETA" stands for "Estimated Time of Arrival", this calculator really should be called "Elapsed Time" or something to that effect.  I may change that in the future.  More importantly, there is a bug that I have not gotten around to fixing.  It is somehow related to the start time being set to PM and the end time being set to AM.  The minutes field is displaying a negative number.  If we were to think of the clock as a mathematical graph, the minutes value is showing as the reflection of what it's value should be.  For example, if the PM start minutes are 15 and the AM end minutes are 30, the value shown is -45 whereas it SHOULD be showing 15.  Kind of odd but I'll try to get that sorted out one of these days... 
