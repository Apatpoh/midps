<?php
$str = explode(":",$_POST['action']);
if (count($str) == 2)
{
	if ($str[1] === 'delete')
	{
		$login = $str[0];
		$s = explode("\n", file_get_contents("../private/users.db"));
		foreach ($s as $str)
		{
			$vechi = $str;
			$str = explode(", ", $str);
			if ($str[0] === $login)
			{
				$nou = file_get_contents("../private/users.db");
				$nou = str_replace($vechi."\n", '', $nou);
				file_put_contents("../private/users.db", $nou);
			}
		}
	}
}
else
{
	$login = $str[0];
	$column = strtolower($str[1]);
	$action = $str[2];
	$s = explode("\n", file_get_contents("../private/users.db"));
	foreach ($s as $str)
	{
		$vechi = $str;
		$str = explode(", ", $str);
		if ($str[0] === $login)
		{
			if ($column === 'login')
				$str[0] = $action;
			elseif ($column === 'password')
				$str[1] = hash("whirlpool", $action);
			elseif ($column === 'name')
				$str[2] = $action;
			elseif ($column === 'surname')
				$str[3] = $action;
			elseif ($column === 'email')
				$str[4] = $action;
			elseif ($column === 'administrator')
				$str[5] = $action;
			$to_modify = implode(", ", $str);
			$nou = file_get_contents("../private/users.db");
			$nou = str_replace($vechi, $to_modify, $nou);
			file_put_contents("../private/users.db", $nou);
		}
	}
}
?>


<html>
<meta charset="utf-8"/>
<title>Menu</title>
<link rel="stylesheet" href="../style/index.css"/>
<link rel="stylesheet" href="../style/header.css"/>
<link rel="stylesheet" href="../style/basket.css"/>
<link rel="stylesheet" href="../style/logs.css"/>

<body>
	<br/><br/>
	<div class="global_div">
		<div class="fromcenter">
			<h1>Users:</h1>
			<table>
				<tr style="border: 2px; border-color: black;">
					<th class="th_third" style="color: black;">Login</th>
					<th class="th_third">Name</th>
					<th class="th_third">Surname</th>
					<th class="th_third">E-mail</th>
					<th class="th_third">Administrator</th>
				</tr>
				<?php
				$s = explode("\n", file_get_contents("../private/users.db"));
				foreach ($s as $str)
				{
					$str = explode(", ", $str);
					echo '<tr>
					<td class="th_first">'.$str[0].'</td>
					<td class="th_third">'.$str[2].'</td>
					<td class="th_third">'.$str[3].'</td>
					<td class="th_third">'.$str[4].'</td>
					<td class="th_third">'.$str[5].'</td></tr>';
			}
			?>
		</table>
	</div>
	<br/><br/>
</div>
</body>

</html>