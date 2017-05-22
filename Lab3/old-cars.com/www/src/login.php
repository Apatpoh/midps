<?php
	include_once 'auth.php';
	session_start();
	function is_admin($name)
	{
		$s = explode("\n", file_get_contents("../private/users.db"));
		foreach ($s as $str)
		{
			$str = explode(", ", $str);
			if ($str[0] === $name)
			{
				if ($str[5] == 1)
					return TRUE;
				return FALSE;
			}
		}
	}

	if (auth($_POST['login'], $_POST['passwd']))
	{
		$_SESSION['loggued_on_user'] = $_POST['login'];
		$_SESSION['administrator'] = is_admin($_POST['login']);
		if (isset($_SESSION[$_SESSION['loggued_on_user']]))
			$_SESSION['basket'] = $_SESSION[$_SESSION['loggued_on_user']];
		header("Location: ./index.php");
	}
	else
	{
		$_SESSION['loggued_on_user'] = '';
		header("Location: ./login_form.php");	
	}
?>