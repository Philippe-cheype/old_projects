// https://discordapp.com/oauth2/authorize?client_id=[___ID___]&scope=bot&permissions=268446720

const Discord = require('discord.js');

const bot = new Discord.Client();
const token = '[___YOUR_TOKEN___]';
const gen = Math.floor(Math.random() * 10)

const alpha = ["a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"]

const topImage = "https://i.imgur.com/sonKaJH.jpg"
const bottomImage = "https://i.imgur.com/kTcQein.jpg"

bot.on("ready", () => { 
	console.log("George . is online.");
	bot.user.setActivity("Your friendly neighbour");

});
bot.on('message', message => {
	const randIntAlpha = Math.floor(Math.random() * Math.floor(25));
	const randIntProb = Math.round(Math.random() * 10);
	let args = message.content.charAt(0);

	if (args == alpha[randIntAlpha]) {
		if(randIntProb != 7) {
			message.channel.send({files: [topImage]});
		}
	}

})

bot.login(token);
