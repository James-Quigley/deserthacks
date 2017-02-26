import {Exception} from "./base.exception"

export class MissingParameterException extends Exception{
  constructor(param){
    super("Missing Parameter: "+param);
  }
}
