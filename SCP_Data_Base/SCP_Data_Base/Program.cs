using System;

namespace SCP_Data_Base
{
    internal class Program
    {
        public SCP startSCP { get; private set; }
        public SCP currentSCP { get; private set; }

        private static int selectionArrowIndex;
        private static void Main(string[] args)
        {
            SCPContainer container = new SCPContainer();

            MainWiki scp_035 = new SCP("SCP_035",
                                       "Keter",
                                       "SCP-035 is to be kept within a hermetically sealed glass case, no fewer than 10 centimeters (4 inches) thick. This case is to be contained within a steel, iron and lead-shielded room at all times. Doors are to be triple-locked at all times, with the exception of allowing personnel in or out. No fewer than two (2) armed guards are to be posted at any time. Guards must remain outside at all times and are not allowed within the containment room under any circumstances. A trained psychologist is to remain on site at all times. Research personnel are not to touch SCP-035 at any time. SCP-035 must be moved to a new sealed case every two (2) weeks. The previous case must be disposed of via SCP-101, as it shows no adverse reactions to SCP-035's “corruption”. Anyone who comes into contact with SCP-035 when it is in possession of a host is to be given an immediate psychological evaluation.",
                                       "SCP-035 was found in a sealed crypt in an abandoned house in Venice, in 18██",
                                       "SCP-035 appears to be a white porcelain comedy mask, although, at times, it will change to tragedy. In these events, all existing visual records, such as photographs, video footage, even illustrations, of SCP-035 automatically change to reflect its new appearance.",
                                       "Addendum 035-01: SCP-035 has been found to be able to possess anything that has a humanoid shape, including mannequins, corpses, and statues. SCP-035 has been able to motivate all into movement, removing the need to expose live subjects to SCP-035. Still, anything it possesses inevitably decays into motionlessness");
            MainWiki scp_049 = new SCP("SCP-049",
                                       "Euclid",
                                       "SCP-049 is contained within a Standard Secure Humanoid Containment Cell in Research Sector-02 at Site-19. SCP-049 must be sedated before any attempts to transport it. During transport, SCP-049 must be secured within a Class III Humanoid Restriction Harness (including a locking collar and extension restraints) and monitored by no fewer than two armed guards. While SCP - 049 is generally cooperative with most Foundation personnel, outbursts or sudden changes in behaviour are to be met with elevated force.Under no circumstances should any personnel come into direct contact with SCP - 049 during these outbursts.In the event SCP-049 becomes aggressive, the application of lavender (L.multifida) has been shown to produce a calming effect on the entity.Once calmed, SCP-049 generally becomes compliant, and will return to containment with little resistance. In order to facilitate the ongoing containment of SCP-049, the entity is to be provided with the corpse of a recently deceased animal (typically a bovine or other large mammal) once every two weeks for study.Corpses that become instances of SCP-049-2 are to be removed from SCP-049's containment cell and incinerated. SCP-049 is no longer permitted to interact with human subjects, and requests for human subjects are to be denied.",
                                       "(See Addendum 049.3) Per Containment Committee Order 049.S19.17.1, SCP-049 is no longer permitted to interact directly with any members of Foundation staff, nor is it to be provided with any additional corpses to be used in its surgeries. This order shall persist indefinitely, until such time a consensus regarding the ongoing containment of SCP-049 can be reached.",
                                       "SCP-049 is a humanoid entity, roughly 1.9 meters in height, which bears the appearance of a medieval plague doctor. While SCP-049 appears to be wearing the thick robes and the ceramic mask indicative of that profession, the garments instead seem to have grown out of SCP-049's body over time1, and are now nearly indistinguishable from whatever form is beneath them. X-rays indicate that despite this, SCP-049 does have a humanoid skeletal structure beneath its outer layer.",
                                       "Starting shortly after SCP-049's initial containment, Dr. Hamm conducted a number of interviews with the subject regarding its anomalous properties, and over time began to note its displeasure with its subjects and the SCP-049-2 instances. This continued for a period of several months, during which SCP-049 never exhibited any aggressive behaviours. On April 16th, 2017, as Dr. Hamm was entering SCP-049's test chamber to conduct another routine interview, the entity began to grow anxious and asked Dr. Hamm if he was feeling well. Following protocol, Dr. Hamm reminded SCP-049 that the interview was required, after which the entity became hostile and attacked Dr. Hamm, killing him. Due to a lapse in security protocol, and because Dr. Hamm did not activate the in-chamber emergency system, Dr. Hamm's corpse was not discovered until three hours later, by which point SCP-049 had converted it into an instance of SCP-049-2. In the aftermath of this incident, SCP-049 was interviewed by Dr. Theron Sherman.");
            MainWiki scp_069 = new SCP("SCP_069",
                                       "Safe",
                                       "SCP-069 is currently impersonating former Foundation Agent ███████ █████, and is housed at Humanoid Containment Site-06-3. SCP-069 is to be provided with any reasonable requested item and/or material so long as such request does not violate Foundation security protocols. As SCP-069 is currently on suicide watch, all requests it makes must be approved by no fewer than two (2) Level 3 personnel. If SCP-069 attempts to breach containment, it must be subdued using non-lethal methods. If SCP-069 dies, undercover agents are to be instructed to monitor reports of incidents in which individuals appear to have escaped certain death and SCP-069 is to be re-contained as soon as possible. If SCP-069 attempts to breach containment, it must be subdued using non-lethal methods. If SCP-069 dies, undercover agents are to be instructed to monitor reports of incidents in which individuals appear to have escaped certain death and SCP-069 is to be re-contained as soon as possible.",
                                       "SCP-069 is a presumed humanoid entity of variable appearance and gender. Through an unknown ability, whenever SCP-069 is left alone with a recently deceased human body, the body will disappear and SCP-069 will take on the appearance, mannerisms, and knowledge of the recently dead individual. Through extensive experimentation, it has been shown that SCP-069 is completely indistinguishable from the individual it impersonates, matching the original individual's fingerprints, DNA, and [DATA EXPUNGED] with nearly perfect precision. SCP-069 retains no knowledge of its abilities or former impersonations. SCP-069 responds normally to injury and pain, but if killed, will rapidly decay into dust regardless of any preservation attempts. SCP-069 will then re-emerge at the site of the most recent human death. There is no known maximum range to this effect, and so far has been observed in jumps of up to 675 kilometers. SCP-069 can impersonate a single individual indefinitely. However, it will gain an overriding urge to 'get their life in order', including but not limited to: resolving any outstanding financial or personal obligations, visiting extended family, updating their will and testament, and other acts of closure. When questioned, SCP-069 professes no driving motivation other than a desire to straighten out their lives in the event of unforeseen injury or death. SCP-069 first came to the Foundation's attention on █/██/199█ following reports of one John M███████, a █████████ City firefighter who miraculously emerged alive from a 3-alarm building fire in which 2 other firefighters and 11 civilians perished. Undercover agents attached to the local authorities were notified of a possible SCP when reports emerged that the firefighter's equipment had been damaged beyond recognition, and that it had been deemed nearly impossible for the firefighter to emerge unscathed. Approximately three weeks later, then-presumed John M███████ responded to another large-scale building fire, during which he entered a smoke-filled room alone and was never found. A single civilian was rescued from the building, again nearly unharmed despite the heavy smoke reported within the building. SCP-069 was designated the following day, and rendered into Foundation custody by members of Mobile Task Force Xi-3 ('Body Snatchers').",
                                       "Addendum 069-01: On ██/█/200█, Agent ███████ █████, a guard on duty assigned to SCP-069, was killed during the containment breach of SCP-███ and subsequently impersonated by SCP-069. Although initially in denial after being informed of its identity, it has been mostly cooperative since its impersonation of a mid-level Foundation employee. Contingencies for the use of deceased Foundation employees for future SCP-069 use is under consideration.",
                                       "Addendum 069-02: On ██/██/200█, SCP-069 attempted to commit suicide after a junior researcher accidentally informed it that the family of Agent █████ had been told that Agent █████ was dead, and of their subsequent reactions. Due to the massive cost of possibly having to re-contain SCP-069, strict suicide watch measures are to be implemented. Plans to use other deceased Foundation employees as possible impersonation targets for SCP-069 have been suspended.");
            Console.WriteLine("What SCP do you want to learn more of? (035/049/069)");
            string chooseSCP = Console.ReadLine();

            if (chooseSCP == "SCP-035" || chooseSCP == "scp-035" || chooseSCP == "035" || chooseSCP == "SCP 035" || chooseSCP == "scp 035")
            {
                selectionArrowIndex = 1;
            }
            if (chooseSCP == "SCP-049" || chooseSCP == "scp-049" || chooseSCP == "049" || chooseSCP == "SCP 049" || chooseSCP == "scp 049")
            {
                selectionArrowIndex = 2;
            }
            if (chooseSCP == "SCP-069" || chooseSCP == "scp-069" || chooseSCP == "069" || chooseSCP == "SCP 069" || chooseSCP == "scp 069")
            {
                selectionArrowIndex = 3;
            }

            container.AddID(scp_035);
            container.AddID(scp_049);
            container.AddID(scp_069);

            container.Use(selectionArrowIndex);

        }

        public void Run()
        {
            if (currentSCP == null)
            {
                currentSCP = startSCP;
            }
            Console.WriteLine($"You're in the {currentSCP}\n");
            Console.WriteLine(currentSCP + "\n");
        }

        private int AskForInput(int maxNumber)
        {
            int input;
            if (int.TryParse(Console.ReadLine(), out input))
            {
                if (input < maxNumber)
                {
                    return input;
                }
                Console.WriteLine("Invalid Input: Option not available.");
            }
            else
            {
                Console.WriteLine("Invalid Input: Please insert a number.");
            }

            return AskForInput(maxNumber);
        }
    }
}