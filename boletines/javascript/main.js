//DOM
/*let links = document.querySelectorAll("a");
links.forEach(function(link){
	console.log(link);
});*/

//Obtengo los elementos de la clase close
let links = document.querySelectorAll(".close");

links.forEach(function(link)
{
	link.addEventListener("click", function(ev)
	{
		ev.preventDefault();

		let content = document.querySelector('.content');

		//Quitamos las clases de animación que tiene
		content.classList.remove("bounceInDown");
		content.classList.remove("animated");

		//Agregamos las clases de salida
		//Quitamos las clases de animación que tiene
		content.classList.add("bounceOut");
		content.classList.add("animated");

		setTimeout(function(){
			location.href = "../index.html";
		}, 600);
		return false;
	});
});
