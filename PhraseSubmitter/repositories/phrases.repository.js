import {
    BaseRepository
} from "./base.repository";

export class PhrasesRepository extends BaseRepository {
    constructor(db) {
        super(db);
        this._collection = this.db.collection("phrases");
    }

    async listPhrases() {
        let result = await this.collection.find().toArray();
        console.log(result);
        return result;
    }

    async insert(phrase) {
        let result = await this.collection.insert(phrase);
        console.log(result);
        return result;
    }

    async delete() {
        let result = await this.collection.remove({});
        console.log(result);
        return result;
    }
}
