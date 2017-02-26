var mongodb = require('mongodb');

export class BaseRepository {
  constructor(db){
    this._db = db;
    this._mongodb = mongodb;
  }

  get db(){return this._db;}
  get collection(){return this._collection;}
}
