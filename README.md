# The Igra

## Ovaj repository
Ovaj repositori se sastavlja od jednostavne folder strukture:
- **docs:** Ovaj folder sadrzava sve dokumente i formulare bitne za projekat.
- **The Igra:** U ovom folderu se nalaze svi podatci Unity projekta.
- **links:** U ovom fodleru su svi potrebni linkovi skupljeni koji sadrzavaju tutoriale i slicno.

## How to contribute
Ima vise mogucnosti raditi na ovom repositoriju. Jako je bitno dokumentirati sadasnji i budci rad.
Dokumentacija ce se voditi poput ToDo liste na dnu ovog README-ja. Developer bi trebao da obelezi na kojiem ToDo time da si kopira task u svoju listu i stavi je u WIP (Work in progress). Staviti u WIP se tako radi da se nadoveze mali tag Sa statusom i planiranim datumom zavrsetka tog taska. Primer (WIP, 4.3.22). Ako iz nekog slucaja neki task blokira mora se prebaciti u stalled, sa komentaraom ko je radio na njemu zasto je zaustavljen i pod kojim konicijama se moze nastaviti.

## Git workflow:
Svaki promena u git repozitoriju bi trebala da se prvo uradi u novom brancu. Taj branc bi trebao da sezove po borju taskia i kratkim opisu. Na primer: T001_setup_unity_project. To olaksava svima odredjivati koji branc pripada kojem tasku. Commitovi trebali bi isto da pocnu sa Task brojom. Primer: T001: adds projectfiles. Nakon sto je task zavrsen se otvara PR request koji mora drugi konributre da reviewa i da potvrdi da bi moglo sve da se merga u main branch.

Updatovanje Task moze da se odradi u main branchu.

## Task List
### Unassigned Tasks:
- [ ] T000: opis primer

### Stalled Tasks:
- [ ] Opis taska: Problem, kad ce se nastaviti. Ime predhodnog developera

### Milos Tasks:
- [ ] T005: Pripremiti formular i pronaci Linkove za tutoriale i download stranice za assetse (WIP)

### Adri Tasks:
- [ ] T003 odradi Unity Essentials tutorial koji se nalazi u Links folderu
- [ ] T004 upoznaj se sa repositorijem kloniraj ga i otvori Projekat u unityju (req T000 i T001 done).

### Togehter Tasks:
- [ ] T004 Game Specification

### Done Tasks
- [x] T000 Setup repo
- [x] T001 Setup project
