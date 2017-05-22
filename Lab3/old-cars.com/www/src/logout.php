<?php
	session_start();
	$_SESSION[$_SESSION['loggued_on_user']] = $_SESSION['basket'];
	$_SESSION['loggued_on_user'] = '';
	$_SESSION['administrator'] = '';
	$_SESSION['basket'] = array();
	header("Location: ./index.php");
?>