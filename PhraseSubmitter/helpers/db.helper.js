"use strict";
var mongodb = require('mongodb');

import {DBConfig} from "../config/db.config";

export class DBHelper{
  constructor(){
    this._mongoClient = mongodb.MongoClient;

    this._db = null;
  }

  get mongoClient(){ return this._mongoClient; }
  get db(){ return this._db; }


  async init(){
    return await this.mongoClient.connect("mongodb://"+DBConfig.username+":"+DBConfig.password+"@"+DBConfig.ip+":"+DBConfig.port+"/"+DBConfig.database)
    .then((database) => {
      console.log('2')

      return database;
    })
  }
}
