var express = require('express');
var router = express.Router();

/* GET home page. */
router.get('/', function(req, res, next) {
    res.json("Hello!")
});
router.post('/sendmessage', function(req, res, nest) {
    var channel = req.body.channel;
    var mesasge = req.body.message;
    //post to https://slack.com/api/chat.postMessage

})
module.exports = router;
