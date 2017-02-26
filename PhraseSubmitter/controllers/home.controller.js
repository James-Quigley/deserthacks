import {
    BaseController
} from "./base.controller";
export class HomeController extends BaseController {
    constructor(server) {
        super(server);
        this.router.get('/materializecss', (req, res) => {
            this.getMaterializeCss(req, res);
        });
        this.router.get('/materializejs', (req, res) => {
            this.getMaterializeJs(req, res);
        });
        this.router.get('/jquery', (req, res) => {
            this.getJquery(req, res);
        });
        this.router.get('/css', (req, res) => {
            this.getCss(req, res);
        });
        this.router.get('/', (req, res) => {
            this.get(req, res);
        });
    }

    get(req, res) {
        res.contentType('text/html')
        res.sendfile('./public/index.html');
    }

    getMaterializeCss(req, res) {
        res.sendfile('./public/sass/materialize.css');
    }

    getMaterializeJs(req, res) {
        res.sendfile('./public/js/bin/materialize.min.js');
    }

    getJquery(req, res) {
        res.sendfile('./public/js/jquery-3.1.1.min.js');
    }

    getCss(req, res) {
        res.sendfile('./public/styles.css');
    }

}
