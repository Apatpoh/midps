<?php
	function auth($login, $passwd)
	{
		$passwd = hash("whirlpool", $passwd);
		$s = explode("\n", file_get_contents("../private/users.db"));
		foreach ($s as $str)
		{
			$str = explode(", ", $str);
			if ($str[0] === $login && $str[1] === $passwd)
				return TRUE;
		}
		return FALSE;
	}
?>
