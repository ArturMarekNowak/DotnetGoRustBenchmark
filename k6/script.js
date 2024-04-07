import { check } from 'k6';
import http from 'k6/http';

export const options = {
  scenarios: {
    test: {
      exec: 'test',
      executor: 'constant-arrival-rate',
      duration: '10s',
      preAllocatedVUs: 100,
      rate: 10,
    }
  }
};


export function test() {
  const res = http.get('http://localhost:8080/helloWorld');

  check(res, {
    'is status 200': (r) => r.status === 200,
  });
}

/*export function test() {
   const res = http.get('http://localhost:8081/helloWorld');

   check(res, {
     'is status 200': (r) => r.status === 200,
   });
}*/

/* export function test() {
   const res = http.get('http://localhost:8082/helloWorld');
  
   check(res, {
     'is status 200': (r) => r.status === 200,
   });
 }*/

/*export function test() {
  const res = http.get('http://localhost:8080/users/1');
  
  check(res, {
    'is status 200': (r) => r.status === 200,
  });
}*/

/*export function test() {
  const res = http.get('http://localhost:8081/users/1');
  
  check(res, {
    'is status 200': (r) => r.status === 200,
  });
}*/

/*export function test() {
  const res = http.get('http://localhost:8082/users/1');
  
  check(res, {
    'is status 200': (r) => r.status === 200,
  });
}*/
