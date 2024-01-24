import { Basics } from "../SandBox/Basics";
let basics = new Basics();
test("Swapper in place code", () => {
  expect(basics.swapper_in_place(1, 2)).toEqual([2, 1]);
});
