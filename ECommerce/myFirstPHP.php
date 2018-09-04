<!DOCTYPE html>
<html>
<body>
<?php
//This is my first PHP document which displays some data in the web browser
$myName = "Zackary Harnett";
$randomNumber = 53870;
$userAgent = $_SERVER['HTTP_USER_AGENT'];
$fileName = $_SERVER['PHP_SELF'];
$ipAddress = $_SERVER['REMOTE_ADDR'];

echo "<br>My name is $myName";
echo "<br>The random number given is $randomNumber";
echo "<br>The name of the web browser and operating system being used is $userAgent";
echo "<br>The file name of the currently running script is $fileName";
echo "<br>The IP address the user is viewing this page from is $ipAddress";
?>
</body>
</html>
