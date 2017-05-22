<?php
	$error = TRUE;
	$s = explode("\n", file_get_contents("../private/users.db"));
	foreach ($s as $str)
	{
		$str = explode(", ", $str);
		if ($str[0] === $_POST['login'] || $str[4] === $_POST['email'])
			$error = FALSE;
	}

	if ($error && filter_var($_POST['email'], FILTER_VALIDATE_EMAIL))
	{
		file_put_contents("../private/users.db", $_POST['login'].", ".hash("whirlpool", $_POST['passwd']).", ".$_POST['name'].", ".$_POST['surname'].", ".$_POST['email'].", "."0"."\n", FILE_APPEND);
		header("Location: ./index.php");
	}
?>

<html>
<head>
	<title>Create Account</title>
	<link rel="stylesheet" type="text/css" href="../style/index.css">
	<link rel="stylesheet" type="text/css" href="../style/header.css">
	<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>
	<link rel="stylesheet" href="../style/logs.css">
</head>
<body>
	<br/><br/>
	<form class="form" method="post" action="reg.php">
		<input type="text" placeholder="username" name="login"/>
		<input type="password" placeholder="password" name="passwd"/>
		<input type="text" placeholder="name" name="name"/>
		<input type="text" placeholder="surname" name="surname"/>
		<input type="email" placeholder="email address" name="email"/>
		<input id="submit" type="submit" name="submit" value="submit"/>
		<p class="message">Already registered? <a href="./login.php">Sign In</a></p>
	</form>
</body>
</html>