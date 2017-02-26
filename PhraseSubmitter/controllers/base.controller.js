var express = require('express')
import {MissingParameterException} from "../models/exceptions/missingParameter.exception";
import {JsonResponse} from "../models/jsonResponse.model";


export class BaseController{
  constructor(server){
    this._server = server;
    this._router = express.Router();

    this.router.get('/', (req, res)=>{this.get(req, res)});
    this.router.post('/', (req, res)=>{this.post(req, res)});
    this.router.put('/', (req, res)=>{this.put(req, res)});
    this.router.delete('/', (req, res)=>{this.delete(req, res)});
  }

  get app(){return this._app;}
  get router(){return this._router;}


  get(req, res){
    res.contentType("application/json");
    res.send('triggered get');
  }

  post(req, res){
    res.contentType("application/json");
    res.send('triggered post');
  }

  put(req, res){
    res.contentType("application/json");
    res.send('triggered put');
  }

  delete(req, res){
    res.contentType("application/json");
    res.send('triggered delete');
  }



  expectParameters(expectedParams, providedParams){
    for(let param in expectedParams){
      if(providedParams[param] == null)
        throw new MissingParameterException(param);
    }
  }
}
