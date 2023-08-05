> test info

test suite: `nbomber_default_test_suite_name`

test name: `nbomber_default_test_name`

session id: `2023-08-05_15.23.65_session_ef91f23c`

> scenario stats

scenario: `Обращение по адресу: tests/sync.`

- ok count: `9901`

- fail count: `0`

- all data: `0` MB

- duration: `00:01:40`

load simulations:

- `inject`, rate: `100`, interval: `00:00:01`, during: `00:01:40`

| step               | ok stats                                                                |
| ------------------ | ----------------------------------------------------------------------- |
| name               | `global information`                                                    |
| request count      | all = `9901`, ok = `9901`, RPS = `99`                                   |
| latency            | min = `2057,38`, mean = `4910,25`, max = `17338,34`, StdDev = `2400,15` |
| latency percentile | p50 = `4122,62`, p75 = `5586,94`, p95 = `10149,89`, p99 = `14139,39`    |

> status codes for scenario: `Обращение по адресу: tests/sync.`

| status code | count | message |
| ----------- | ----- | ------- |
| OK          | 9901  |         |

THREADPOOL: THREAD-COUNT: 69
