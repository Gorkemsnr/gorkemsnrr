<?php
	$kadi="admin";
	$ksifre="1234";
	
 if(isset($_POST['login'])){
	$kullanici=$_POST['kullanici'];
	$sifre=$_POST['sifre'];
	if($kullanici==$kadi and $sifre==$ksifre){
		if(isset($_POST['hatırla'])){
		setcookie('kullanici',$kullanici,time()+60*60*7);
		}
		session_start();
		$_SESSION['kullanici']=$kullanici;
		header("location: hosgeldin.php");
	}else{
		echo "kullanici adı veya şifre hatalıdır</br>tekrar denemek için  <a href='login.php'>tıklayın</a>";
	}
	}else{
		header("location: login.php");
	}
 
?>