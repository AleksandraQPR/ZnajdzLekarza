import { Localization } from "./localization";
import { Service } from "./services";
import { Specialization } from "./specialization";

export interface Specialist {
  id: number;
  firstName: string;
  lastName: string;
  email: string;
  phoneNumber: string;
  description?: string;
  education?: string;
  localizations: Localization[];  
  specializations?: Specialization[]; 
  services?: Service[];  

}
