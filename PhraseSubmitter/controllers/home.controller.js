import {BaseController} from "./base.controller";
export class HomeController extends BaseController{
  constructor(server){
    super(server);
  }

  get(req, res){
    res.contentType('text/html')
    res.sendfile('./public/index.html');
  }
}
