// https://discordapp.com/oauth2/authorize?client_id=[___ID___]&scope=bot&permissions=11264

const Discord = require('discord.js');
var request = require("request");
var cheerio = require("cheerio");

var api = 'https://mcsrvstat.us/server/'
var server = '[___IP_OF_SERVER_TO_CHECK___]';

const bot = new Discord.Client();
const token = '[___YOUR_TOKEN___]';
var PREFIX = '$';

bot.on("ready", () => {
	console.log("MCSSP Bot is online.");
	bot.user.setActivity(PREFIX + "help");

});

bot.on('message', message => {
	if (message.author.bot) return;
	if (message.content.indexOf(PREFIX) !== 0) return;

	let args = message.content.substring(PREFIX.length).split(" ");

	switch(args[0]){
		case 'help':
			var helpEmbed = new Discord.MessageEmbed()
				.setColor('#57932F').addFields(
					{ name: '**' + `${PREFIX}` + 'help**', value: '└ permet d\'ouvrir ce menu.' },
					{ name: '**' + `${PREFIX}` + 'info**', value: '└ permet de voir combien joueurs sont en ligne sur un serveur.' },
					{ name: '**' + `${PREFIX}` + 'server [IP du serveur]**', value: '└ permet de definir le serveur à espionner.' },
					{ name: '**' + `${PREFIX}` + 'prefix [nouveau prefix]**', value: '└ permet de changer le prefix.' }
				).setFooter('Made by @NDexis#1500   •   v1.1.1')

			message.delete({ timeout: 20000 });
			message.channel.send(helpEmbed).then(msg => { msg.delete({ timeout: 20000 }); })
			break;

		case 'server':
			var serverEmbed = new Discord.MessageEmbed()
				.setColor('#57932F')
				.addField( '- Server -', 'J\'espionne **__' + `${server}` + '__** en ce moment.\r\rUtilisez :\r$server [IP du serveur]\rpour que je change de cible.' );

			if(!args[1]){
				message.delete({ timeout: 20000 });
				message.channel.send(serverEmbed).then(msg => { msg.delete({ timeout: 20000 }); })
			} else {
				server = args[1];

				var serverChangedEmbed = new Discord.MessageEmbed()
				.setColor('#57932F')
				.addField( '- Server -', 'J\'espionne **__' + `${server}` + '__** maintenant.' );

				message.delete({ timeout: 20000 });
				message.channel.send(serverChangedEmbed).then(msg => { msg.delete({ timeout: 20000 }); })
			}
			break;

		case 'prefix':
			var prefixEmbed = new Discord.MessageEmbed()
				.setColor('#57932F')
				.addField( '- Prefix -', 'Mon prefix est : **' + `${PREFIX}` + '** . \r\rChangez le avec :\r$prefix [nouveau prefix].' );


			if(!args[1]){
				message.delete({ timeout: 20000 });
				message.channel.send(prefixEmbed).then(msg => { msg.delete({ timeout: 20000 }); })
			} else {
				PREFIX = args[1];
				bot.user.setActivity(PREFIX + "help");

				var prefixChangedEmbed = new Discord.MessageEmbed()
					.setColor('#57932F')
					.addField( '- Prefix -', 'Nouveau prefix : **' + `${PREFIX}` + '** .' )

				message.delete({ timeout: 20000 });
				message.channel.send(prefixChangedEmbed).then(msg => { msg.delete({ timeout: 20000 }); })
			}
			break;

		case 'info':
			var infoErrorEmbed = new Discord.MessageEmbed()
				.setColor('#57932F')
				.addField( '- Info -', '**__' + `${server}` + '__** n\'est pas en ligne.' );

			message.delete({ timeout: 20000 });
			message.channel.send('`Calcul en cours...`').then(msg => { msg.delete({ timeout: 1000 }); })

			request(api + server, (error, response, html) => {
				if(!error && response.statusCode === 200) {
					const cheer = cheerio.load(html);
					var players = cheer('.table').find('tbody > tr:nth-child(2) > td:nth-child(2)').text();
					var players = players.replace(/\s/g, "")
					var players = players.split("/")[0];
				}

			var infoEmbed = new Discord.MessageEmbed()
				.setColor('#57932F')
				.addField( '- Info -', 'Pour **__' + `${server}` + '__** il y à \r**' + `${players}` + '** joueur(s) en ligne.' );

				if (players == '') {
					message.channel.send(infoErrorEmbed).then(msg => { msg.delete({ timeout: 20000 }); })
				} else {
					message.channel.send(infoEmbed).then(msg => { msg.delete({ timeout: 20000 }); })
				}
			});
			break;
	}
});

bot.login(token);
