import {
    HomeController
} from "../controllers/home.controller";
import {
    PhrasesController
} from "../controllers/phrases.controller";


export class Router {
    constructor(server) {
        this._server = server;
        this.init();
    }

    get server() {
        return this._server;
    }

    init() {
        this.server.app.use('/', new HomeController(this.server).router);
        this.server.app.use('/phrases', new PhrasesController(this.server).router);
    }
}
