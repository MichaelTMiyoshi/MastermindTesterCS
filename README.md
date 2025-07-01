# MastermindTesterCS

This short code tests a mastermind scoring function.  To use it, understand that the guess and secret are sent to the testing function as arrays of bytes.  This means that you will need to make sure that your testing function can handle these two byte arrays.  The code also assumes that you are using four pins of six possible colors.  These colors are represented by the numbers 1-6.

If you do not get 100% correct, the code will tell you the percentage or correct answers and which test is the first failure.
