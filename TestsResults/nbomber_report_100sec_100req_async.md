> test info

test suite: `nbomber_default_test_suite_name`

test name: `nbomber_default_test_name`

session id: `2023-08-05_15.30.26_session_8a0247a4`

> scenario stats

scenario: `Обращение по адресу: tests/async.`

- ok count: `9965`

- fail count: `0`

- all data: `0` MB

- duration: `00:01:40`

load simulations:

- `inject`, rate: `100`, interval: `00:00:01`, during: `00:01:40`

| step               | ok stats                                                               |
| ------------------ | ---------------------------------------------------------------------- |
| name               | `global information`                                                   |
| request count      | all = `9965`, ok = `9965`, RPS = `99,6`                                |
| latency            | min = `2097,96`, mean = `5409,33`, max = `18578,91`, StdDev = `2445,4` |
| latency percentile | p50 = `4648,96`, p75 = `6377,47`, p95 = `10379,26`, p99 = `13410,3`    |

> status codes for scenario: `Обращение по адресу: tests/async.`

| status code | count | message |
| ----------- | ----- | ------- |
| OK          | 9965  |         |

THREADPOOL: THREAD-COUNT: 51
