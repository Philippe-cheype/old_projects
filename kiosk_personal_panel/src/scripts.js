function temperature() {
    fetch("http://api.openweathermap.org/data/2.5/weather?q=Nice&appid=64d396add46be7a89c3e5a2fdd1ace91&lang=fr&units=metric").then(res => res.json()).then(data => document.getElementById("temperature").innerHTML = Math.round(data.main.temp) + "°C");
}

function time() {
    var today = new Date();
    var f = "AM";
    var h = today.getHours();
    var m = today.getMinutes();

    m = checkTime(m);
    if (h < 12) {
        f = "AM";
    } else if (h > 12) {
        f = "PM";
        h -= 12;
    }
    document.getElementById('time').innerHTML = h + ":" + m + f;
    var t = setTimeout(time,15000);
}

function checkTime(i) {
    if (i < 10) {
        i = "0" + i;
    }
    return i;
}

function date() {
    n = new Date();
    y = n.getFullYear();
    m = n.getMonth() + 1;
    d = n.getDate();

    if (y == 2020) {
        y = 20;
    }
    if (m < 10) {
        m = "0" + m
    }
    document.getElementById("date").innerHTML = d + "/" + m + "/" + y;
}

var toggle = "t";

function website_change() {
    var t = "https://twitter.com/home";
    var p = "https://instagram.com";

    if (toggle == "t") {
        toggle = "p";
        document.getElementById('website').data = p;
    } else if(toggle == "p") {
        toggle = "t";
        document.getElementById('website').data = t;
    }
}
