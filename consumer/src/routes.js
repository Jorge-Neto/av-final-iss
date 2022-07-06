import { Router } from "express";
import FolhasController from "./app/controllers/FolhasController.js";

const routes = new Router();

routes.get("/", (req, res) => {
    res.json({ message: "API que auxilia a API A" });
});

routes.get("/conta/saldo/:agencia/:conta", FolhasController.saldo);
routes.get("/conta/movimentacoes/:agencia/:conta", FolhasController.movimentacoes);

export default routes;
