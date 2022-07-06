import app from "./app.js";
import {
  consume,
  // deposit,
  // withdraw
} from "./utils/consumer.js";

const PORT = 3001;

consume().catch((err) => {
  console.error("error in consumer: ", err)
});
// deposit().catch((err) => {
//   console.error("error in deposit: ", err)
// });
// withdraw().catch((err) => {
//   console.error("error in withdraw: ", err)
// });

app.listen(PORT, () => {
  console.log("Node server is running on: http://localhost:3001/");
});
