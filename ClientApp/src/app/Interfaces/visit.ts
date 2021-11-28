import { Localization } from "./localization";
import { Service } from "./services";
import { Specialist } from "./specialist";

export interface Visit {
  id: number;
  date: Date;
  specialist: Specialist;
  localization: Localization;
  service: Service;
  price: number;
}
