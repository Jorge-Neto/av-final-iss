import { Kafka } from "kafkajs";
import FolhasController from "../app/controllers/FolhasController.js";

const clientId = "group_id"
const brokers = ["localhost:9092"]
const kafka = new Kafka({ clientId, brokers })

const consumer = kafka.consumer({ groupId: "group_id" })

export const consume = async () => {
    await consumer.connect()
    await consumer.subscribe({ topics: ["queue_kafka", "queue_depositar", "queue_sacar"] })
    await consumer.run({
        eachMessage: ({ message }) => {
            if (message.key.toString() === "cadastrar") {
                console.log(`Conta para processar: ${message.value}`)
                FolhasController.inputConta(JSON.parse(message.value.toString()));
            }
            if (message.key.toString() === "depositar") {
                console.log(`Depósito Recebido: ${message.value}`);
                FolhasController.updateSaldo(JSON.parse(message.value.toString()), "depositar");
            }
            if (message.key.toString() === "sacar") {
                console.log(`Saque efetuado: ${message.value}`)
                FolhasController.inputConta(JSON.parse(message.value.toString()), "sacar");
            }
        },
    })
}
