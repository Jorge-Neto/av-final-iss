package br.com.iss.kafka.consumer.listener;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.kafka.annotation.KafkaListener;
// import org.springframework.stereotype.Component;
import org.springframework.stereotype.Service;

import br.com.iss.kafka.consumer.models.Payroll;

@Service
public class ConsumerListener {
    private static final Logger LOGGER = LoggerFactory.getLogger(ConsumerListener.class);

    @KafkaListener(topics = "queue_kafka", groupId = "group_id")
    public void consume(String message) {
    	LOGGER.info(String.format("Consumindo mensagem -> %s", message));
    }
}
