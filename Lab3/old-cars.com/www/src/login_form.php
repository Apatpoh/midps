<html>
<head>
	<title>Login</title>
	<link rel="stylesheet" type="text/css" href="../style/index.css">
	<link rel="stylesheet" type="text/css" href="../style/header.css">
	<link rel="stylesheet" type="text/css" href="../style/logs.css">
</head>
<body>
	<br/><br/>
	<form action="login.php" method="post" class="form">
		<input type="text" placeholder="username" name="login"/>
		<input type="password" placeholder="password" name="passwd"/>
		<input type="submit" name="submit" value="submit">
		<p class="message">Not registered? <a href="./reg.php">Create an account</a></p>
	</form>
</body>
</html>
