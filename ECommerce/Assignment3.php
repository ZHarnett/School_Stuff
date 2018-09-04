<?php

  ini_set('display_errors','1');
  error_reporting(E_ALL);


if(isset($_POST['first_name_field'])){
  if (ini_get('magic_quotes_gpc')) {
	   $firstNameField = $_POST['first_name_field'];
     echo '<br>First name is ' .$firstNameField;
}
  elseif(!ini_get('magic_quotes_gpc')){
      $firstNameField = addslashes($_POST['first_name_field']);
      echo '<br>First name is ' .$firstNameField;
  }
  else{
    echo "<br>First name data cannot be read";
  }
}
else{
  echo '<br>First name unentered';
}

if(isset($_POST['last_name_field'])){
  if (ini_get('magic_quotes_gpc')) {
	   $lastNameField = $_POST['last_name_field'];
     echo '<br>Last name is ' .$lastNameField;
}
  elseif(!ini_get('magic_quotes_gpc')){
      $lastNameField = addslashes($_POST['last_name_field']);
      echo '<br>Last name is ' .$lastNameField;
  }
  else{
    echo "<br>Last name data cannot be read";
  }
}
else{
  echo '<br>Last name unentered';
}

if(isset($_POST['email_input_field'])){
  if (ini_get('magic_quotes_gpc')) {
	   $emailInputField = $_POST['email_input_field'];
     echo '<br>Last name is ' .$emailInputField;
}
  elseif(!ini_get('magic_quotes_gpc')){
      $emailInputField = addslashes($_POST['email_input_field']);
      echo '<br>Email name is ' .$emailInputField;
  }
  else{
    echo "<br>Email name data cannot be read";
  }
}
else{
  echo '<br>Last name unentered';
}

if(isset($_POST['password_input_field'])){
  if (ini_get('magic_quotes_gpc')) {
	   $passwordInputField = $_POST['pasword_input_field'];
     echo '<br>Password name is ' .$passwordInputField;
}
  elseif(!ini_get('magic_quotes_gpc')){
      $passwordInputField = addslashes($_POST['password_input_field']);
      echo '<br>Password name is ' .$passwordInputField;
  }
  else{
    echo "<br>Password name data cannot be read";
  }
}
else{
  echo '<br>Password name unentered';
}

if(isset($_POST['project_textarea'])){
  if (ini_get('magic_quotes_gpc')) {
	   $addressField = $_POST['project_textarea'];
     echo '<br>Address is ' .$addressField;
}
  elseif(!ini_get('magic_quotes_gpc')){
      $addressField = addslashes($_POST['project_textarea']);
      echo '<br>Address is ' .$addressField;
  }
  else{
    echo "<br>Address data cannot be read";
  }
}

echo '<br>The pull down choice is ' .$_POST['first_pull_down'];
$firstPullDown = $_POST['first_pull_down'];

if(isset($_POST['radio_buttons'])){
$buttonChoice = $_POST['radio_buttons'];
echo '<br>The radio buttons choice is ' .$buttonChoice;
}
else{
echo '<br>button error';
}
//assistance found at http://www.html-form-guide.com/php-form/php-form-checkbox.html
$aCheckbox = $_POST['unchecked_checkbox'];
if(empty($aCheckbox))
{
  echo("You didn't select anything.");
}
else
{
  $H = count($aCheckbox);

  echo("<br>You selected $H hat(s): ");
  for($i=0; $i < $H; $i++)
  {
    echo($aCheckbox[$i] . " ");
  }
}


 ?>
