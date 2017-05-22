<?php
	include 'header.php';
?>

<!DOCTYPE html>
<html>
	<meta charset="utf-8">
	<link rel="stylesheet" href="../style/index.css">
<head>
	<title>Old Cars</title>
</head>
<body>
	<br/><br/>
	<center>
	<img class="removable" src="../img/banner_3.jpg" width="100%">
	</center>
	<div id="prod_nav">
      <ul>
        <li><a href="?query=pontiac"><img src="../img/1.jpg" width="200" alt=""><strong>Pontiac</strong></a></li>
        <li><a href="?query=plymouth"><img src="../img/2.jpg" width="200" alt=""><strong>Plymouth</strong></a></li>
        <li><a href="?query=chevrolet"><img src="../img/3.jpg" width="200" alt=""><strong>Chevolet</strong></a></li>
        <li><a href="?query=dodge"><img src="../img/4.jpg" width="200" alt=""><strong>Dodge</strong></a></li>
        <li><a href="?query=ford"><img src="../img/5.jpg" width="200" alt=""><strong>Ford</strong></a></li>
      </ul>
    </div>
	<div class="global_div">
		<br class="removable"/><br class="removable"/>
		<center><img class="removable" src="../img/banner_4.jpg" width="1200px"></center>
		<br/><br/>
		<?php
			$category = array('pontiac', 'plymouth', 'chevrolet', 'dodge', 'ford');
			foreach ($category as $var)
			{
				if ($_GET['query'] == $var)
				{
					echo '<style>.removable{display: none;}</style>';
					echo '<div class="fromcenter"><ul class="product" align="center">';
					$s = explode("\n", file_get_contents("../private/products.db"));
					foreach ($s as $str)
					{
						$str = explode(", ", $str);
						if ($str[0] == $_GET['query'])
						{
							echo '<li class="categ">
							<img src="'.$str[2].'" width="250px" />
							<form action="addtocart.php" method="post">
							<input style="border-style: none; font-size: 20px; text-align: center; font-style: bold;" type="text" name="name" value="'.$str[1].'" readonly/>
							<p class="info_prod">'.$str[3].' cm2 | '.$str[4].'</p>
							<h2>'.$str[5].' $</h2>
							</form>
							</li>';
						}				
					}
					echo '</ul></div>';
				}
			}

			function get_restaurants()
			{
				$arr = explode("\n", file_get_contents("../private/products.db"));
				foreach ($arr as $value)
				{
					$value = explode(", ", $value);
					$rs[] = $value[4];
				}
				$rs = array_unique($rs);
				return $rs;
			}
			
			$restaur = get_restaurants();
			foreach ($restaur as $var)
			{
				if ($_GET['query'] && $_GET['query'] == $var)
				{
					echo '<style>.removable{display: none;}</style>';
					echo '<div class="fromcenter"><ul class="product" align="center">';
					$s = explode("\n", file_get_contents("../private/products.db"));
					foreach ($s as $str)
					{
						$str = explode(", ", $str);
						if ($str[4] == $_GET['query'])
						{
							echo '<li class="categ">
							<img src="'.$str[2].'" width="250px" />
							<form action="addtobasket.php" method="post">
							<input style="border-style: none; font-size: 20px; text-align: center; font-style: bold;" type="text" name="name" value="'.$str[1].'" readonly/>
							<p class="info_prod">'.$str[3].' | '.$str[4].'</p>
							<h2>'.$str[5].' lei</h2>
							<input type="submit" name="submit" value="Adauga in cos"/>
							</form>
							</li>';
						}				
					}
					echo '</ul></div>';
				}
			}
		?>
		</div>
		<br/>
		<br/>
	</div>
</body>
</html>