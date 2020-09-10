/* Open when someone clicks on the span element */
function openMENU() {
	document.getElementById("my-hidden-nav").style.width = "100%";
}

/* Close when someone clicks on the "x" symbol inside the overlay */
function closeMENU() {
	document.getElementById("my-hidden-nav").style.width = "0%";
}
// Navbar hide on scroll
var prevScrollpos = window.pageYOffset;
window.onscroll = function() {
	var currentScrollPos = window.pageYOffset;
	if (currentScrollPos<150){
		document.getElementById("hide-onscroll").style.display = "none";
	}
	else{
		document.getElementById("hide-onscroll").style.display = "block";
		if (prevScrollpos > currentScrollPos) {
			if (currentScrollPos<300){
				document.getElementById("hide-onscroll").style.top = "-150px";
			}
			else{
				document.getElementById("hide-onscroll").style.top = "0";
			}
		} 
		else {
			document.getElementById("hide-onscroll").style.top = "-150px";
		}
		prevScrollpos = currentScrollPos;
	}
}