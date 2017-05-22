<?php
	session_start();
?>

<link rel="stylesheet" href="../style/header.css">
<ul class="header">
	<div class="altu">
		<div class="dropdown">
			<li class="dropbtn" style="padding: 0;">
				<a href="."><img src = "../img/logoo.png" width="300px"></a>
			</li>
		</div>
		<div class="dropdown" style="float:right; margin-right: 5vw;">
			<li class="dropbtn">
				<?php 
					if ($_SESSION['loggued_on_user'] == '')
						echo "Authentification";
					else
						echo $_SESSION['loggued_on_user'];
				?>	
			</li>
				<?php
					if ($_SESSION['loggued_on_user'] == '')
						echo '<div class="dropdown-content">
						<a href="./reg.php">Inregistrare</a>
						<a href="./login.php">Login</a>
						</div>';
					else
					{
						echo '<div class="dropdown-content">
						<a href="./logout.php">Logout</a>
						</div>';
					}
				?>
	</div>
	<?php
				if ($_SESSION['administrator'] === true)
				{
					echo '<div class="dropdownss"><li class="dropbtnss"><a class="top_links" href="./users.php">Users</a></li></div>';
					echo '<div class="dropdownss"><li class="dropbtnss"><a href="./add.php">Add</a></li></div>';
				}
			?>
</ul>
