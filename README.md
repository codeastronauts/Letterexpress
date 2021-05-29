# Letterxpress
Letterxpress.de Library

Important links:
* [Quick Start](https://github.com/codeastronauts/Letterxpress/wiki/Quick-Start)
* [Create sandbox account](https://sandbox.letterxpress.de/anmelden/)

## Usage
The usage is simple. Here is an example of how your balance is displayed.  
![](https://i.imgur.com/lm4T1Wa.png)

## Example
![](https://i.imgur.com/ugtybKL.png)
### Result
![](https://i.imgur.com/19krPSp.png)

## API coverage
| Endpoint   | Implemented |
|------------|-------------|
| getPrice   | ✅           |
| getBalance | ✅           |
| getJobs/queue | ❓ (Testing not yet possible)           |
| getJobs/sent | ❓ (Testing not yet possible)           |
| getJobs/deleted | ✅           |
| getJobs/queue/(int)days | ❓ (Testing not yet possible)           |
| getJobs/sent/(int)days | ❓ (Testing not yet possible)           |
| getJobs/deleted/(int)days | ✅           |
| getJobs/hold | ❓ (Testing not yet possible)           |
| getJobs/timer | ✅           |
| getJob/(int)id | ✅           |
| setJob | ✅           |
| updateJob/(int)id | ✅           |
| deleteJob/(int)id | ✅           |
| listInvoices | ❌           |
| getInvoice | ❌           |
| getInvoice/(int)id | ❌           |