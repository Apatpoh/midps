<?php
	$error = TRUE;
	if ($_POST['p_type'] == '' || $_POST['p_name'] == '' ||  $_POST['p_img'] == ''
		|| $_POST['p_mass'] == '' || $_POST['p_rest'] == '' || $_POST['p_price'] == '')
		$error = FALSE;

	if ($error)
	{
		file_put_contents("../private/products.db", $_POST['p_type'].", ".$_POST['p_name'].", ".$_POST['p_img'].", ".$_POST['p_mass'].", ".$_POST['p_rest'].", ".$_POST['p_price']."\n", FILE_APPEND);
		header("Location: ./index.php");
	}
?>

<html>
<head>
	<title>Add a Car</title>
	<link rel="stylesheet" type="text/css" href="../style/index.css">
	<link rel="stylesheet" type="text/css" href="../style/header.css">
	<link rel="stylesheet" type="text/css" href="../style/logs.css">
</head>
<body>
	<br/>
	<br/>
	<form action="add.php" method="post" class="form">
		<p class="message" style="margin-bottom: 15px; font-size: 20px;">Add a product:</p>
		<input type="text" placeholder="Car Model" name="p_type"/>
		<input type="text" placeholder="Car Name" name="p_name"/>
		<input type="text" placeholder="Car Image" name="p_img"/>
		<input type="text" placeholder="Engine Capacity" name="p_mass"/>
		<input type="text" placeholder="Car Year" name="p_rest"/>
		<input type="number" placeholder="Car Price" name="p_price"/>
		<input type="submit" name="submit" value="submit">
	</form>
</body>
</html>