# cleanCoding
The following programming task was set for me during a recent internship.
Here is the specification:

A person who has a bad motor accident can be awarded a payment stream for the rest of their life by the UK courts.  

What we have:

1) The age of the life at the settlement date: 10
2) A series of payments, starting immediately at the settlement date, at the start of each year for n years.
3) A probability of survival for each year of life . i.e. the probability that a y year-old will live to y+1
4) There is a discount rate of 1.5%


What we need:

A C# function that returns, at any point during the payment stream , the ‘value’ of the outstanding series of payments:  
1) Discount the cashflow to the specified time
2) Multiply each cashflow by the probability of survival for that age
