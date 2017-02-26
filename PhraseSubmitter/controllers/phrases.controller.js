import {
    BaseController
} from "./base.controller";
import {
    JsonResponse
} from "../models/jsonResponse.model";
import {
    PhrasesRepository
} from "../repositories/phrases.repository";

export class PhrasesController extends BaseController {
    constructor(server) {
        super(server);
        this._repository = new PhrasesRepository(server.db);
        this.router.get('/', (req, res) => {
            this.get(req, res);
        });
        this.router.post('/', (req, res) => {
            this.post(req, res);
        });
        this.router.delete('/', (req, res) => {
            this.deleteAll(req, res);
        });
    }

    async get(req, res) {
        try {
            let result = await this._repository.listPhrases();
            await this._repository.delete();
            res.json(new JsonResponse({
                success: true,
                message: "Searched correctly",
                data: result
            }));
        } catch (ex) {
            res.json(new JsonResponse({
                success: false,
                message: ex.message
            }));
        }
    }

    async post(req, res) {
        try {
            res.json(new JsonResponse(await this._repository.insert(req.body)));
        } catch (ex) {
            res.json(new JsonResponse({
                success: false,
                message: ex.message
            }));
        }
    }

    async deleteAll(req, res) {
        try {
            res.json(new JsonResponse(await this._repository.delete()));
        } catch (ex) {
            res.json(new JsonResponse({
                success: false,
                message: ex.message
            }));
        }
    }
}
