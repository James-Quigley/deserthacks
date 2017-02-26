"use strict";
require("babel-core/register");
require("babel-polyfill");
var bodyParser = require("body-parser");
var cors = require('cors');

var http = require('http'),
    express = require('express'),
    app = express();

import {
    ServerConfig
} from "./config/server.config";
import {
    Router
} from "./config/routing.config";
import {
    DBHelper
} from "./helpers/db.helper";

class Server {
    constructor() {
        this._app = express();

        this.init();
    }

    get app() {
        return this._app;
    }
    get db() {
        return this._db;
    }
    get router() {
        return this._router;
    }


    async init() {
        this._db = await new DBHelper().init();
        this._app.use(cors());
        this.app.use(bodyParser.urlencoded({
            extended: false
        }))
        this.app.use(bodyParser.json());
        this._router = new Router(this);
        this.app.listen(ServerConfig.port, () => {
            console.log(ServerConfig.startupMessage)
        });

    }



}

let server = new Server()
