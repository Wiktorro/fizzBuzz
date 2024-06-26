#include <assert.h>
#include <ctype.h>
#include <limits.h>
#include <math.h>
#include <stdbool.h>
#include <stddef.h>
#include <stdint.h>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

char* readline();
char* ltrim(char*);
char* rtrim(char*);

int parse_int(char*);

/*
 * Complete the 'fizzBuzz' function below.
 * The function accepts INTEGER n as parameter, iterates [1,N]
 */

void fizzBuzz(unsigned int n) {
// funkcja ktora musialem napisac, reszta byla gotowa
    for(unsigned int i=1 ; i <= n; ++i) {
        if( 0 == i % 3) {
            if( 0 == i % 5 ) printf("%s", "FizzBuzz\n");
            else  printf("%s", "Fizz\n");
        }
        else if( 0 == i % 5)  printf("%s", "Buzz\n");
        else printf("%d\n", i);
    }
}

int main()
{
    const int n = parse_int(ltrim(rtrim(readline())));

    fizzBuzz(n);

    return 0;
}

char* readline() {
    size_t alloc_length = 1024;
    size_t data_length = 0;

    char* data = (char*) malloc(alloc_length);

    while (true) {
        char* cursor = data + data_length;
        char* line = fgets(cursor, alloc_length - data_length, stdin);

        if (!line) {
            break;
        }

        data_length += strlen(cursor);

        if (data_length < alloc_length - 1 || data[data_length - 1] == '\n') {
            break;
        }

        alloc_length <<= 1;

        data = (char*) realloc(data, alloc_length);

        if (!data) {
            data = NULL;
            break;
        }
    }

    if (data[data_length - 1] == '\n') {
        data[data_length - 1] = '\0';

        data = (char*) realloc(data, data_length);

        if (!data) {
            data = NULL;
        }
    } else {
        data = (char*) realloc(data, data_length + 1);

        if (!data) {
            data = NULL;
        } else {
            data[data_length] = '\0';
        }
    }

    return data;
}

char* ltrim(char* str) {
    if (!str) {
        return NULL;
    }

    if (!*str) {
        return str;
    }

    while (*str != '\0' && isspace(*str)) {
        str++;
    }
    return str;
}

char* rtrim(char* str) {
    if (!str) {
        return NULL;
    }

    if (!*str) {
        return str;
    }

    char* end = str + strlen(str) - 1;

    while (end >= str && isspace(*end)) {
        end--;
    }
    *(end + 1) = '\0';

    return str;
}

int parse_int(char* str) {
    char* endptr;
    int value = strtol(str, &endptr, 10);

    if (endptr == str || *endptr != '\0') {
        exit(EXIT_FAILURE);
    }
    return value;
}
