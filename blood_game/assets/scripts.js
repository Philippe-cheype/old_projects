var health_value = 1
var bandaid = false;

function health(health_value) {
	document.getElementById('high_health').style.opacity = health_value;
	document.getElementById('low_health').style.opacity = 1 - health_value;
	document.getElementById('health_num').innerHTML = Math.round(100 * health_value);
}

function cut() {
	health_value = health_value - 0.01;
	health(health_value);
	if (health_value <= 0) {
		bandaid = true;
	};
	return;
}

function negatives(x) {
	if (x == 1) {
		while (bandaid == false) {
			setTimeout(cut(), 1000);
		}
	} else if (x == 2) {
		return;
	} else if (x == 3) {
		return;
	} else if (x == 4) {
		return;
	} else if (x == 5) {
		health(0);
	} else {
		return;
	}
}
