'use strict';
const Alexa = require('alexa-sdk');
const _ = require('lodash');
//VI-REMOVE:const VoiceInsights = require('voice-insights-sdk');
var https = require('https');
https.post = require('https-post');
const request = require('request');
const Config = require('./config/skill.config');

request.debug = true;
module.exports.handler = (event, context, callback) => {
    const alexa = Alexa.handler(event, context);
    alexa.appId = Config.skillAppID;
    alexa.registerHandlers(mainHandlers);
    alexa.execute();
};

var mainHandlers = {
    'SubmitPhrase': function() {
        var message = this.event.request.intent.slots.Message.value;
        console.log(message);

        var headers = {
            'Content-Type': 'application/json'
        }

        // Configure the request
        var options = {
            url: 'http://52.41.27.101:443/phrases',
            method: 'POST',
            headers: headers,
            json: {
                'data': message
            }
        }
        console.log(options);
        // Start the request
        var that = this;
        request(options, function(error, response, body) {
            if (!error && response.statusCode == 200) {
                // Print out the response body
                console.log(body)
                that.emit(':tellWithCard', "Okay", Config.skillNamespace, message);
            } else {
                console.log(error);
                that.emit(':tellWithCard', "Oops! I ran into a problem.", Config.skillNamespace, message);
            }

        });
    }
};
